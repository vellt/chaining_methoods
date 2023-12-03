# Fluent Interface Design Pattern
> The project's service theme is: oragize the students into groups of a certain number

This simple project based on the fluent interface design pattern. Which does help us to be our project more readable and provides an easy to use format for using this service. Which looks like this:

```C#
GroupService.MakeOf(students)
            .In(count)
            .Print();
```

