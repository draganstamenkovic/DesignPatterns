# Design Patterns in Unity

## Introduction
Design patterns are internal systems which are solving specific problems and half of the battle is alignment with the problem you have with design pattern which solves it best. There is a right time and place for using design patterns, but overusing them can bring you complexity which is not needed and it can waste you a lot of time.

**Good code is not just about solving the problem at hand, but about crafting a solution that is elegant, maintainable, and adaptable. Design patterns are the timeless blueprints that guide us in this craft, offering wisdom from those who have walked the path before. Embrace them not as rigid rules, but as tools to create clarity, simplicity, and beauty in your code—because the best code is not just written for machines, but for the humans who will read, understand, and evolve it.**

Design patterns that I covered here are:
 - Command
 - Prototype
 - Factory Method

### Command Pattern
The Command Pattern is a behavioral design pattern that encapsulates a request as an object, thereby allowing for parameterization of clients with different requests, queuing of requests, and support for undoable operations. It is an excellent choice for handling player input, implementing replay systems, or managing action histories in games or applications.

In the example, a Stack is used to manage commands. When a new command is executed, it is pushed onto the stack using Stack.Push(). To undo the most recent command, the Stack.Pop() method is called, which removes and reverts the latest command. This approach is particularly useful for implementing features like "undo" functionality in text editors, game move reversals, or step-by-step replay systems.

For instance, in a game, you could use the Command Pattern to handle player movements. Each movement command (e.g., "Move Forward," "Jump," "Attack") would be encapsulated as an object. These commands can then be stored in a stack, allowing the player to undo their last action or replay a sequence of actions seamlessly.

### Prototype Pattern
The Prototype Pattern is a creational design pattern that allows you to create copies of existing objects without making your code dependent on their specific classes. This is particularly useful when creating new objects is more expensive or complex than copying existing ones.

In game development, the Prototype Pattern is often used to create instances of objects that share similar properties but require slight modifications. A great analogy for this is the use of Prefabs in Unity. Prefabs act as templates for game objects, and you can create variants of these Prefabs by modifying their properties (e.g., changing the color, size, or behavior of an enemy character).

For example, imagine you have a base enemy Prefab with default attributes like health, speed, and attack power. Using the Prototype Pattern, you can create multiple variants of this enemy by cloning the base Prefab and adjusting its properties. This approach saves time and resources, as you don’t need to recreate the entire object from scratch for each variant.
## NOTE
- I created this repository with examples for design patterns i used before in my project as a reminder, cause thank god we all forget sometimes. You might find some examples here usefull or otherwise, but if you find it otherwise i encourage you to open the issue.
