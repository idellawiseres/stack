# stack
A stack is an abstract data structure in which elements are organized according to the LIFO (Last In First Out) principle.

The principle of operation of a stack can be compared to a stack of books - in order to take the second book from the top, you first need to put the first one aside.

The stack algorithm, in its simplest implementation, is as follows:

each new element is added to the top of the stack, while all subsequent elements are shifted one position down;
we can get from the stack only the element located at the top (it is also called the head element), while it is removed from the stack, and the subsequent ones are shifted up a position;
Thus, if the stack is not empty, the last added element is always located at the top, with which we can interact.

In the System.Collections.Generic library of the C# language, there is already a .Net implementation of the Stack class, but to understand the structure of this data structure, we will write our own implementation of the stack.

Standardly, three operations are implemented for the stack:

Push - method of adding a new element to a vertex;
Pop - reading an element and deleting it;
Peek - reading the head element without removing it from the stack.
We will add the following to these operations:

Size - getting the size of the stack structure;
Clear - method for clearing the stack.
