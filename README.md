# DesignPatterns.AbstractFactory
Code sample for Abstract Factory pattern.

## Objective
Support an interface to create relationed families of objects or that 
dependents ***without specify your concrete classes***.

##More about the Abstract Factory
1. It's creational pattern;
2. It's a factory like the Factory Method and generally is composed with multiple Factory Mathods;
3. Separate the creation code from the code who uses the objects (Principle of Unique Responsibility);
4. Easy implementation of new families of objects (Open/Close Principle);
5. Focused in interfaces and not in implementations.

## When to use this approach
Use Abstract Factory when: \
\
1. the system must be independent who your products are created, composited or represented;
2. a system have to be  configured like a product for a family of a multiple products;
3. a family of objects be made to be used in paralel and you need to guarantee this restriction;
4. you want to give a product class library and want to show only your interfaces, and not your implementations.

##UML for example that I thought here
I made an example for a real world case:

##

