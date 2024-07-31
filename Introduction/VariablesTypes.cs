namespace Introduction
{
    public class VariablesTypes
    {
        // Boolean: To store boolean values (true or false).
        bool isTrue = true; // true

        // Unsigned integer: To store small positive integers.
        byte age = 25; // 25

        // Signed integer: To store small integers.
        sbyte temp = -5; // -5

        // Character: To store a single Unicode character.
        char letter = 'A'; // 'A'

        // Decimal: To store decimal values with high precision, such as monetary values.
        decimal price = 19.95M; // 19.95M

        // Double-precision floating-point: To store double-precision floating-point numbers.
        double height = 1.75; // 1.75

        // Single-precision floating-point: To store single-precision floating-point numbers.
        float weight = 70.5F; // 70.5F

        // Signed integer: To store medium-sized integers.
        int count = 100; // 100

        // Unsigned integer: To store medium-sized positive integers.
        uint uCount = 100U; // 100U

        // Signed long integer: To store large integers.
        long distance = 100000L; // 100000L

        // Unsigned long integer: To store large positive integers.
        ulong uDistance = 100000UL; // 100000UL

        // Signed short integer: To store small integers.
        short shortNum = -300; // -300

        // Unsigned short integer: To store small positive integers.
        ushort uShortNum = 300; // 300

        // Object: To store any type of object.
        object obj = new object(); // new object()

        // String: To store text strings.
        string message = "Hello"; // "Hello"

        // Date and time: To store date and time information.
        DateTime now = DateTime.Now; // 27/07/2024 14:35:21 (example output)

        // Time span: To store a duration or interval of time.
        TimeSpan interval = new TimeSpan(1, 30, 0); // 01:30:00

        // Globally unique identifier: To store unique global identifiers.
        Guid id = Guid.NewGuid(); // 3f9b9c38-01e6-41f1-943e-7b908e4d1e8f (example output)

    }
}
