# ADP Software Templates
Software templates and catalog entities for the [ADP portal](https://github.com/defra-adp-sandpit/adp-portal). The templates and entities in this repository are referenced as catalog locations in the adp-portal project.

## What are ADP Software Templates used for?
This repository contains the full structures (templates) to scaffold an entire application business application/microservice, including 'hello world' code examples in either NodeJS or C#. These templates include GDS styling, mock UI or backend, CI & CD pipelines, tests, docker files HELM charts, etc. The platform currently has a scaffolder for NodeJs frontends (UI) and backends / APIs. 

Any updates to the scaffolded applications via backstage should be made here and will be applied to every newly scaffolded and deployed microservice. 

## Repository structure
The repository contains YAML files which define the entities loaded into the software catalog. The [Backstage documentation](https://backstage.io/docs/features/software-catalog/descriptor-format) describes the fields which are required in the entities. The repository is organised as follows:

* **catalog-model** - contains certain entities (domains, resources, systems) which are shared between components. Any entities defined here should be added to the relevant location file in the root of this folder to be picked up by Backstage. This folder is broken down into sub-folders:
    * **defra** - contains [group](https://backstage.io/docs/features/software-catalog/system-model#group) entities used to model Defra as on organisation in the portal. This is broken down into arms-length bodies (ALBs), delivery programmes, and projects.
    * **domains** - contains [domains](https://backstage.io/docs/features/software-catalog/system-model#domain) which are used to group systems to an area within the business.
    * **systems** - contans [systems](https://backstage.io/docs/features/software-catalog/system-model#system) which are used to group the components and resources which form a functional system.
    * **resources** - [resources](https://backstage.io/docs/features/software-catalog/system-model#resource) are the 3rd party infrastructure a component needs to work, e.g. database servers and service bus namespaces. Shared ADP resources should be defined in this repo. Individual resources, e.g. databases and message queues should be defined alongside the component that consumes them.
* **templates** - contains software templates which can be used to scaffold new services from the portal. Each template folder should contain a [template.yaml](https://backstage.io/docs/features/software-catalog/descriptor-format#kind-template) file which defines the templates, steps, and actions required to scaffold a new service using the template, and a skeleton folder which contains a tokenised version of the project to be created. The template.yaml file must be added to `/catalog-model/org-templates.yaml` to be picked up by Backstage.

```
├── catalog-model
|   ├── defra
|   ├── domains
|   ├── resources
|   └── systems
└── templates
    ├── template-1
    |   └── skeleton
    └── template-2
        └── skeleton
```
