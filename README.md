# SocialStockBot
A stock bot attempting to make prediction on stock moving directions based on intel gathered from social media sites.


## Introduction
Just another stock bot. However, this specific stock bot is intended to pull and process real-time stock information and mentions from social media sites such as Twitter, Facebook and Reddit. 
This information will be used in an attempt to estimate the direction of stocks based on their number of positive/negative mentions throughout the community.

## Architecture
The stock bot leverages the open-source full-text search engine Elasticsearch for information storage. During development Elasticsearch and Kibana is setup on a RPi 4.

An overview of the intended architecture can be seen in the image below:
![Architecture](/Information/Architecture_overview.svg)

### Web Client
Fetches information from social media sites and stores it into Elasticsearch. Plan is to add functionality for interfacing with stock brokers and automating stock rotation.

### Web Interface Administration
A management web client for editing settings and interfacing with the application.

### Data Processor
Fetches and processes data from Elasticsearch. Makes the predictions of stock movements.

## Storage Architecture
A first draft for the index planning for Elasticsearch can be seen in the image below:
![Index Architecture](/Information/Index_overview.svg)
