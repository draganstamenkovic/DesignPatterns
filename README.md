# Design Patterns in Unity

## Introduction
Design patterns are internal systems which are solving specific problems and half of the battle is alignment with the problem you have with design pattern which solves it best. There is a right time and place for using design patterns, but overusing them can bring you complexity which is not needed and it can waste you a lot of time.

**Good code is not just about solving the problem at hand, but about crafting a solution that is elegant, maintainable, and adaptable. Design patterns are the timeless blueprints that guide us in this craft, offering wisdom from those who have walked the path before. Embrace them not as rigid rules, but as tools to create clarity, simplicity, and beauty in your code—because the best code is not just written for machines, but for the humans who will read, understand, and evolve it.**

Design patterns that I covered here are:
 - Command
 - Prototype
 - Factory Method

## Creational Design Patterns

### Prototype
**The Prototype Pattern is a creational design pattern that allows you to create copies of existing objects without making your code dependent on their specific classes. This is particularly useful when creating new objects is more expensive or complex than copying existing ones.**

<b>UML class diagram of our example for Prototype Pattern</b>

![Prototype](https://github.com/user-attachments/assets/1f4be421-bfe9-4c83-a527-daddfc7a39d5)

In game development, the Prototype Pattern is often used to create instances of objects that share similar properties but require slight modifications. A great analogy for this is the use of Prefabs in Unity. Prefabs act as templates for game objects, and you can create variants of these Prefabs by modifying their properties (e.g., changing the color, size, or behavior of an enemy character).

For example, imagine you have a base enemy Prefab with default attributes like health, speed, and attack power. Using the Prototype Pattern, you can create multiple variants of this enemy by cloning the base Prefab and adjusting its properties. This approach saves time and resources, as you don’t need to recreate the entire object from scratch for each variant.

### Factory Method

**The Factory Method pattern is a creational design pattern that provides an interface for creating objects without specifying their concrete classes. It defines a method that subclasses can override to create specific object types.**

The main purposes of the Factory Method pattern are:

- To delegate object creation to subclasses, allowing them to decide which specific class to instantiate
- To encapsulate object creation logic, hiding implementation details from client code
- To promote loose coupling by allowing code to work with abstract types rather than concrete implementations
- To support the Open/Closed Principle by making it easy to add new types without modifying existing code

Factory Method is particularly useful when:

- You don't know ahead of time what class of objects you need to create
- You want to let subclasses decide what objects to create
- You want to ensure that a class can only have one instance of each subclass
- You want to localize the knowledge of which class gets created

I used more generic version in project here. So i don't need to create a lot of boiler plate code, like creating class for each factory, but rather using `IEnemyFactory` interface to return `IEnemy` to return type of the enemy base on what we selected in dropdown menu.

### Object pool
**An object pool essentially creates a pool of objects at initialization that are disabled and when you need an object, instead of instantiating a new one you get an already created one from the pool, just enabled.**

### Builder
**Builder pattern is really good choice when you (as the name suggests) build stuff but in the runtime. For example NPC character ally or enemy, also you can do it for similar popups which need the same design but rather needs different text.** 

## Behavioral Patterns

### Command Pattern
The Command Pattern is a behavioral design pattern that encapsulates a request as an object, thereby allowing for parameterization of clients with different requests, queuing of requests, and support for undoable operations. It is an excellent choice for handling player input, implementing replay systems, or managing action histories in games or applications.

<b>UML class diagram of our example for Command Pattern</b>

![CommandPattern](https://github.com/user-attachments/assets/ae3beb93-05ba-448f-9de7-5af5cab87862)

In the example, a Stack is used to manage commands. When a new command is executed, it is pushed onto the stack using Stack.Push(). To undo the most recent command, the Stack.Pop() method is called, which removes and reverts the latest command. This approach is particularly useful for implementing features like "undo" functionality in text editors, game move reversals, or step-by-step replay systems.

For instance, in a game, you could use the Command Pattern to handle player movements. Each movement command (e.g Forward W, Back S, Left A, Right D) would be encapsulated as an object. These commands can then be stored in a stack, allowing the player to undo their last action or replay a sequence of actions seamlessly.


## NOTE
- I created this repository with examples for design patterns i used before in my project as a reminder, cause thank god we all forget sometimes. You might find some examples here usefull or otherwise, but if you find it otherwise i encourage you to open the issue.
