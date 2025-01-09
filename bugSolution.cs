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
        List<SomeDataType> results = new List<SomeDataType>();
        using (var context = new MyDbContext())
        {
            // Some operations using context
            results = context.SomeMethod(); //Store results before the end of the using block
        }

        // Use the results here
        foreach (var item in results)
        {
            // Process each item
        }
    }
}