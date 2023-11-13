# Interfaces-Inheritance 

![Screenshot](https://github.com/ForlornU/Images/blob/ce5151bfacdf828624316683cd02ad11d4e5c6ba/inheritanceinterfacethumbnail.png)

Following below is the source code for a small project I made to showcase how I would use inheritance/abstract classes differently from interfaces.
A lot of things from this project in my video on the topic were not explained properly.

Like how the the weapons almost entirely rely on the Gun() base-class for all of their functionality, execept they are completely free to create their own unique behaviours.
The machine gun is the only one that does so, it can overheat with time. This code only exists on the machine gun sub-class. 
The shotgun may have some kick-back for the one firing it for example, but it was not implemented.

The targets on the right all mostly react the same way to being hit, whats important is that in a real scenario they would all have lots of different logic on them
The enemy has an AI and probably acts on its own, lots of scripts and different behaviours. It wouldnt make sense to add functinality in there for being shot

Likewise the gong has NO other use than being shot, and it will only make a sound. To share an interface that only deals with being shot is most suitable for these classes

-----------

## Getting Started

To get started with this project, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in Unity.
3. Explore the different scripts and ponder the differences between inheritance and interfaces
4. Become wise
