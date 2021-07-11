using Common.Model;
using Nest;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchDataAccess
{
    public abstract class ElasticsearchDataAccessor<T> where T : ElasticsearchIndex
    {
        
        public ElasticsearchDataAccessor()
        {}
        private ElasticClient elasticsearchConnection = null;
        private ConnectionSettings connectionSettings = new ConnectionSettings(new Uri(Settings.ElasticsearchURL));

        private ElasticClient ElasticsearchConnection
        {
            get
            {
                if (elasticsearchConnection == null)
                {
                    elasticsearchConnection = new ElasticClient(connectionSettings);
                }
                return elasticsearchConnection;
            }
        }




        public virtual void IndexDocument(T document)
        {
            document.UpdatedAt = DateTime.Now;

            var response = ElasticsearchConnection.Index(document, i => i.Index(document.IndexName));
            ValidateResponse(response);
        }




        protected virtual bool IndexExists(T document)
        {
            var response = ElasticsearchConnection.Indices.Exists(document.IndexName);

            //Workaround for response to resolve problem: https://github.com/elastic/elasticsearch-net/issues/3950
            if(response.ApiCall.HttpStatusCode != 404)
            {
                ValidateResponse(response);
            }
            else
            {
                return false;
            }
            

            return response.Exists;
        }
        public abstract bool IndexExists();


        protected virtual void CreateIndex(T document)
        {
            var response = ElasticsearchConnection.Indices.Create(document.IndexName, c => c
                .Map<T>(m => m
                    .AutoMap<T>()
                )
            );
            ValidateResponse(response);
        }
        public abstract void CreateIndex();




        protected virtual void DeleteIndex(T document)
        {
            var response = ElasticsearchConnection.Indices.Delete(document.IndexName);
            ValidateResponse(response);
        }
        public abstract void DeleteIndex();





        public virtual T ReadDocument(Key key)
        {
            return ElasticsearchConnection.Get<T>(key.Id, g => g.Index(key.IndexName)).Source;
        }





        private void ValidateResponse(ResponseBase response)
        {
            if(!response.IsValid)
            {
                throw new Exception(response.DebugInformation);
            }
        }
    }
}
