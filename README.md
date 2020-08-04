# FoodShareMory - Food Sharing on Moryx

This a small text project to build a food sharing system based on the MORYX-AbstractionLayer. This is not intended to be a fully functional food sharing system, but as an inspiration and best practice example for the possibilities of the MORYX Framework. 

## Getting Started

Just open the solutions and run the application. Per default this will require access to port 80, alternative you can configure a different port in the **WcfConfig* within the *StartProject*. While the server is running you can open the *MaintenanceWeb* at http://localhost/maintenanceweb/. The *Dashboard* gives you an overview of the application, *Modules* is used to interact and configure modules, *Models* lets you create databases and schemas for installed data models, while *Log* grants live access to all logs.

The *ResourceManager* will fail upon start as it requires a database. First make sure you have [PostgreSQL installed](https://www.postgresql.org/download/), then start the application and open [Database configuration](http://localhost/maintenanceweb/#/databases). Configure the *Moryx.Resources.Model* and create the database. Afterwards restart the failed module, which should now be running with a notification because of the empty database.

The next step is to add an instance of *ResourceInteraction* to use the Resource UI for adding and configuring resources. The *ResourceManager* is pre-configured with an initializer, that creates the interaction endpoint. After the application started and the *ResourceManager* is running, enter the following commands into the console:

```sh
exec ResourceManager initialize 1
reinc ResourceManager
```

Once the module is running, start the front-end and you can create and configure building parts. You can also add additional resource types and drivers by installing their packages in the *StartProject*.

## Trouble Shooting

If you run into problems with the template or MORYX development in general, feel free to join our Gitter channel, ask on StackOverflow using the [`moryx`](https://stackoverflow.com/questions/tagged/moryx) tag or open an issue. In case your back-end application closes directly after start, this is mostly caused by lack of rights, reserved ports or missing libraries. MORYX creates crash log before exiting which can be find in the subdirectory *CrashLogs* in the *StartProjects* execution directory.

## Contribute

If you have an idea to improve a template or can think of a new useful template, please make your changes based on one of the template branches and open a pull request. If you want to add a template, extend the branch list in one commit and the template definition in another. This way we can easily put your template into a separate branch. **Note:** All branches except *master* will be rebased and squashed regularly, to keep them clean. All merge requests that went into a template branch will combined in a single commit and its message appended with following merge request ids.  
