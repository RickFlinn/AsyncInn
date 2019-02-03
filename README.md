# ASyncInn
## Deployed at [https://asyncinny.azurewebsites.net/](https://asyncinny.azurewebsites.net/)
ASyncInn is an MVC, single-page web application designed for Hotel management. It allows users to perform CRUD operations on Hotel location, room, and amenity data. 



## Database Schema 
This application uses relational databases to store and present data about the hotel's properties. 

The database contains tables for AsyncInn locations, rooms, room specifications, amenities, and which amenities are mapped to rooms.

Each HotelLocation has one or more HotelRooms (1:Many), which each have one Room specification (Many:1). Each Room specification has one or more Amenities, which in turn are present in one or more rooms; a (Many:Many) relationship is established with the use of a RoomAmenities join table. 


![Relational database schema](https://github.com/RickFlinn/AsyncInn/blob/master/SchemaAsyncInn.png)
