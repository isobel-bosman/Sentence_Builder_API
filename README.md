# Sentence Builder API

## Getting Started

### Step 1
1. First you will need to load the database onto your local SQL server. To do this ensure SQL server is setup on your machined.

2. Ensure the SQL Connection string in `appsettings.json` is correct.

3. Then run the following command in the Package Manager Console within Visual Studio:
```
update-database
```

### Step 2

There is an endpoint called `Initialize` to populate your SQL database with the words to use from the datasets. 

**NB: Ensure that you run this endpoint for both of the files: "HP.csv" and "LOTR.csv"**

![endpoint](https://user-images.githubusercontent.com/55981550/219966014-54bc11bd-825b-41c8-91d7-0fb11e0a40c0.png)

The files to use are in the root of the GIT repository:

![endpoint2](https://user-images.githubusercontent.com/55981550/219966078-bf369345-0a69-4a87-9f47-e1d6769d8bf6.png)

## Dataset Creation
The datasets were created by using the `part-of-speech tagging` machine learning technique. The [NLTK](https://www.nltk.org/) package is used to achieve this in a Jypiter Notebook found in `dataset_creator` folder.


