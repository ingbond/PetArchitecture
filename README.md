# PetArchitecture
Project created for understanding clean architecture and implement it from scratch.


With Clean Architecture, the Domain and Application layers are at the centre of the design. This is known as the Core of the system.

The Domain layer contains enterprise logic and types and the Application layer contains business logic and types. The difference is that enterprise logic could be shared across many systems, whereas the business logic will typically only be used within this system.

Core should not be dependent on data access and other infrastructure concerns so those dependencies are inverted. This is achieved by adding interfaces or abstractions within Core that are implemented by layers outside of Core. For example, if you wanted to implement the Repository pattern you would do so by adding an interface within Core and adding the implementation within Infrastructure.

All dependencies flow inwards and Core has no dependency on any other layer. Infrastructure and Presentation depend on Core, but not on one another.

![image](https://user-images.githubusercontent.com/23182545/188229099-244e8c77-0715-4887-8b71-bf9834161366.png)
