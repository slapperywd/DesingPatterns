# Solid principles

the term SOLID is a mnemonic acronym for five design principles intended to make software designs more understandable, flexible and maintainable

## Single responsibility principle

a class should have only a single responsibility(i.e.changes to only one part of the software's specification should be able to affect the specification of the class).
in the example below HtmlDocumentPrinter takes responsibility for printing the document, thus each class is doing what he is responsible for
  
  ```sh
 var doc = new Document();
 doc.PrintDocument(new HtmlDocumentPrinter());
            
 ```
 
##  Open/closed principle
"software entities … should be open for extension, but closed for modification."
CalculateTotalDamager() can be overriden which means the method is open for extension and base method stays untouched

 ```sh
var mage = new MageHero();
Console.WriteLine($"Total hero damage : {mage.CalculateTotalDamage()}");
```

## Liskov  substitution principle
objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.
LISKOV principle says the parent should easily replace the child object
What it really means is that if you pass a subclass of an abstraction you need to make sure you don’t alter any behavior or state semantics of the parent abstraction.

```sh
EngineStarter.StartEngine(new Bus());
EngineStarter.StartEngine(new Car());
```

## Interface segregation principle
many client-specific interfaces are better than one general-purpose interface
ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them.

```sh
var phone = new Phone();
phone.Call();
phone.MakeVideo();
phone.TakePhoto();
```

## Dependency inversion principle 
one should "depend upon abstractions, [not] concretions
DI allows to create loose coupled entities

```sh
IWeapon weapon = new Katana();
var ninja = new Ninja(weapon);
ninja.Attack();
```
