## Concepts applied 

![Clean Architecture by Uncle Bob](https://raw.githubusercontent.com/ivanpaulovich/manga/master/docs/CleanArchitecture-Uncle-Bob.jpg)
> The Clean Architecture Diagram by [Uncle Bob](https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html).

| Concept | Description |
| --- | --- |
| DDD | |
| Entity-Boundary-Interactor (EBI) | |
| .NET Core 2.0 and EntityFrameWork 

## API
# http://localhost:57617/api/PackageManager/addpackages
```json
{
  "Name":"new package name",
  "Products":[{
    "Name":"Product1",
    "ProductType":"type1"
  },
  {
    "Name":"Product2",
    "ProductType":"type2"
  },
  {
    "Name":"Product3",
    "ProductType":"type3"
  }
  ]
}
```

# http://localhost:57617/api/PackageManager/updatepackage
```json
{
  "Id": 1,
  "Name":"new name",
  "Products":[{
    "Name":"Product1",
    "ProductType":"type1"
  },
  { 
  	"Id": 2,
    "Name":"new productname 2",
    "ProductType":"type2"
  },
  {
    "Name":"Product4",
    "ProductType":"type3"
  }
  ]
}
```
