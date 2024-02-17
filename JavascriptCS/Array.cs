namespace JavascriptCS
{
    public class Array
    {
       public object[] value { get; set; } = [];
        public Array()
        {

        }
        public Array(int arrayLength)
        {
            value = new object[arrayLength];
        }
        public Array(params object[] elements)
        {
            value = elements;
        }
        public object? at(int index)
        {
            //As stated on MDN (https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/at#index)
            //the array will be interpeted as Array[index] on positive numbers and index - array.Length for negative numbers
            index = index >= 0 ? index : index + value.Length;

            try { 
            return value[index];
            }
            catch
            {
                return null;
            }
        }
        public object[] concat(params object[][] objects)
        {
            List<object> result = [.. value];

            foreach (var objArray in objects)
            {
                foreach (var obj in objArray)
                {
                    // Perform operations on each object
                    // For example, you can print the object or add it to the result list
                    result.Add(obj);
                }
            }

            return [.. result];
        }

    }
}