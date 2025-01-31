public class ExampleClass
{
    public int MyProperty { get; set; }

    // Initialize MyProperty in the constructor
    public ExampleClass()
    {
        MyProperty = 0; // Or any default value
    }

    public void MyMethod()
    {
        // Accessing a property after initialization
        int value = MyProperty + 10; 
    }
}