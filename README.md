🎯 ##Command Design Pattern Example with C#

This project is an implementation of the Command design pattern in C#. It demonstrates how to decouple the sender of a request from the receiver.

🧠 ##What is the Flywieght Pattern?
The Command pattern is used to encapsulate a request as an object, allowing you to parameterize objects with actions, queue or log requests, support undo operations, and create macro commands.

Components

Command (abstract)
Declares the Execute() method.

Concrete Commands

PasteCommand — pastes content into a document

Receivers

Document — perform the actual work

Client

Creates commands, assigns them to receivers, and executes them.

🛠️ Technologies Used
C#

.NET Framework 8.0

🤝 Contributing
Feel free to fork the repository, submit pull requests, or open issues for improvements and discussions.
