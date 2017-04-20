### Intent
- Creates objects without exposing the instantiation logic to the client.
- Refers to the newly created objects through a common interface.

Implementation is very simple:
- The client needs a product, but instead of creating it directly using new operator, just asks to factory object for a new product, providing the information about the type of object it needs
- The factory instantiate a new concrete product and then returns it to the client (casted to abstract product class. in this case it is common interface that client knows)
- The client uses products as abstract products without being aware of their concrete implementation.