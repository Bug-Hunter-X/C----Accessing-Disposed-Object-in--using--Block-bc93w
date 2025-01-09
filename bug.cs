public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // Some operations using context
        }

        // Trying to access context here after disposal will throw an exception
        var result = context.SomeMethod(); 
    }
}