# SingleDesignPattern

# Singleton Pattern vs Static Class
There are two main reasons that you should prefer singleton pattern over a static class.

# Testability
Singletons are well testable while a static class may not;

If your class stores state (data), running multiple tests might effect each other, so writing test will be harder.
Static classes are hard or impossible to mock. So, if you are testing a class depends on the static class, mocking may not be an easy option.
# Extensibility
It is not possible to inherit from a static class, while it is possible with singleton pattern if you want to allow it. So, anyone can inherit from a singleton class, override a method and replace the service.
It is not possible to write an extension method to a static class while it is possible for a singleton object.
