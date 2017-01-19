# BooksWebSite


What it does

Web site to provide users with helpful information about the books that they have. It provides easy and user friendly user interface to search, edit and delete current inventory.


At this point the database is in localhols however could be deploid to Azure or of such kind. 

Description

    This project has 4 folders.
    1. back-end folder is where our web-api is
    2. front-end folder is where our user interface (front end ) is
    4. wiki folder is used for the documentation
    5. F# is where we have our source code for the functional app that analyzes the data
    6. test folder is where our tests are
    This project provides the user with information about crime data

Modeling

This web site is unrealistic. Its purpose is to hit every requirement we have for this project.
We modeled it in a way so we can include everything that it was required from us:
OPP principles: We created our web-api (back end) so we can create hierarchical structure and
implement inheritance, polymorphism and reflection Pipelines, transformers and filters: Instead of having a database, we created F# app to process
huge(6000000 entires) amount of data and give back the required information.
* Data is collected from here https://data.cityofchicago.org/
How To use

    In order to run this project, one has to run local server.
    front-end and back-end are separate apps, both need apace2.
    for front-end point server to point to front-end/web/
    Paste back-end (if not already done) folder from valentin1_jordan2_jose3_final_project/back-end to
    valentin1_jordan2_jose3_final_project/front-end/web/ to construct this path
    valentin1_jordan2_jose3_final_project/front-end/web/back-end
    In order to run this site, one has to change the configuration file named config.php in
    valentin1_jordan2_jose3_final_project/back-end/config.php. Change the global variable $loader to one
    corresponding to the environment. In our case, we run ubuntu and we use "mono".
    If the environment is Windows, change "mono" to "".
    The environment should also have F# installed. Read more how to install F# here http://fsharp.org/use/windows/
    There is nice tutorial at https://www.youtube.com/watch?v=GKqCw_5Szxk.
    In order to run this site, one has to have php installed.
    Of course you can always check the live version at http://carstuff.ddns.net

What is happening ?

    Front End receives input from user. Packs data and makes an HTTP GET Request to back-end
    Back End controller routs to the right class and activates F# program that takes command line arguments,
    filters, maps data and gives data back to front - end
    Note, Every data send to back end is done trough HTTP Request

Testing

    Since the first controller, we created a Testing tool to test our API
    It is Open Source and can be found at https://github.com/guve4e/RESTtest
    It is very helpful, since we can load tests from xml files, and using JSON Schema our tool is telling us
    if our controllers work as suppose to.
    For F# tool we created unit tests
    All source code for testing can be found in the test folder
