public int[] SortArray() 
{
    var n = NumArray.Length;

    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (NumArray[j] > NumArray[j + 1])
            {
                var tempVar = NumArray[j];
                NumArray[j] = NumArray[j + 1];
                NumArray[j + 1] = tempVar;
            }

    return NumArray;
}

var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
var sortFunction = new Bubble();
sortFunction.NumArray = array;

var sortedArray = sortFunction.SortArray();

Assert.IsNotNull(sortedArray);
CollectionAssert.AreEqual(sortedArray, expected);
