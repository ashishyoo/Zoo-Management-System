# Zoo Management System

## Project Overview

This C# project simulates a zoo management system, allowing the creation and management of animals in enclosures, with zookeepers performing tasks like feeding, observing movements, and triggering sounds. The system leverages Object-Oriented Programming (OOP) concepts and design principles to ensure modularity, extensibility, and maintainability.

## OOP Concepts Used

### 1. Encapsulation

The `Animal` class encapsulates attributes like `name`, `species`, `age`, and `defaultFood` as private fields, accessible only through public getter methods (e.g., `GetName()`, `GetSpecies()`). This protects data integrity and hides internal implementation details.

**Example**: In `Animal.cs`, private fields are set via the constructor and accessed via getters, ensuring controlled access.

### 2. Inheritance

The `Animal` class serves as an abstract base class, with specific animal types (`Lion`, `Zebra`, `Eagle`, `Anaconda`) inheriting from it. Each derived class overrides abstract methods (`MakeSound`, `Eat`, `Move`) to provide specific behavior.

**Example**: In `Lion.cs`, `Zebra.cs`, `Eagle.cs`, and `Anaconda.cs`, each class extends `Animal` and customizes its behavior.

### 3. Polymorphism

Polymorphism is achieved through method overriding and the use of generics. The `Enclosure<T>` class works with any `Animal` type, and overridden methods like `MakeSound()` in derived classes allow different animals to exhibit unique behaviors via the same interface.

**Example**: In `Program.cs`, the `mixedHabitat` enclosure calls `MakeSound()` on different animal types, resulting in distinct outputs (e.g., "hisses" for `Anaconda`, "screeches" for `Eagle`).

### 4. Abstraction

The `Animal` class is abstract, defining a contract with abstract methods (`MakeSound`, `Eat`, `Move`) that derived classes must implement. This hides implementation details and exposes only essential behaviors.

**Example**: The `Animal` class in `Animal.cs` ensures all animals share a common interface without exposing how each behavior is implemented.

## Design Principles Used

### 1. Single Responsibility Principle (SRP)

Each class has a single, well-defined responsibility. The `Animal` class defines animal properties and behaviors, `Enclosure` manages a collection of animals, and `ZooKeeper` handles animal care tasks.

**Example**: In `ZooKeeper.cs`, methods like `FeedAnimalInEnclosure` focus solely on feeding, while `Enclosure.cs` handles animal management tasks like adding or removing animals.

### 2. Open/Closed Principle (OCP)

The system is open for extension (new animal types can be added by creating new classes inheriting from `Animal`) but closed for modification (existing code doesn’t need changes to accommodate new animals).

**Example**: Adding a new animal type (e.g., `Tiger`) requires only a new class inheriting from `Animal`, without altering `Enclosure` or `ZooKeeper`.

### 3. Liskov Substitution Principle (LSP)

Any derived class (`Lion`, `Zebra`, etc.) can substitute the base `Animal` class without affecting the program’s behavior, as they implement the same abstract methods.

**Example**: In `Program.cs`, the `mixedHabitat` enclosure accepts any `Animal` type, and methods like `DisplayAnimalsDetails` work seamlessly with any derived class.

### 4. Dependency Inversion Principle (DIP)

High-level modules like `ZooKeeper` and `Enclosure` depend on abstractions (the `Animal` class) rather than concrete implementations. The use of generics in `Enclosure<T>` further abstracts the dependency.

**Example**: `ZooKeeper.cs` interacts with `Enclosure<T>` and `Animal` abstractions, not specific animal types, ensuring flexibility.
