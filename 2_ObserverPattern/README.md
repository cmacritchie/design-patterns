# Observer Pattern


The Observer Pattern defines a one to many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically. Objects observing/subscribing to a subject update automatically whenever the subject state changes.


#### Quick Notes
* think newspaper subscriptions for reverence. Publisher = Subject and subscribers = Observers
* subjects and observers are loosely coupled, the only thing a subject knows about an observer is that it implements a certain interface (the observer interface)
* we can reuse subjects or observers independently of each other. If we have another use for a subject or an observer we can easily reuse them because they aren't tightly coupled
* Changes to either the subject or an observer will not affect the other. Because the two are loosely coupled, we are free to make changes to either, as long as the objects still meet their obligations to implement the subject or observer interfaces.
* Loosely coupled designs allow us to build flexible OO systems that can handle change because they minimize the interdependency between objects.


![strategy pattern](images/observer.JPG)

#### Pros
* strives for loosley coupled designs between objects that interact
* efficiently send data to many objects
* no modifications is needed to be done to the subject to add new observers
* observers can be added and removed any time


#### Cons
* The order of Observer notifications is undependable
* If not used carefully the observer pattern can add unecessary complexity
* The Observer interface has to be implemented by ConcreteObserver, which involves inheritance. There is no option for composition, as the Observer interface can be instantiated.
* Can cause memory leaks known as lapsed listener problem


#### Example Code Explained
In the example code we have concrete weather data coming in. Whenever the Weather data changes, the observers (current conditions display, stats display,  forecast display) are automatically updated. After several instances of weather data we decide that forecast isn't important so we remove it as an observer and continue to get 2 more pieces of weather data which only update the remaining two observers.


###### References
###### Freeman, Eric; Robson, Elisabeth; Bates, Bert; Sierra, Kathy. Head First Design Patterns (Kindle Location 1132). O'Reilly Media. Kindle Edition. 
