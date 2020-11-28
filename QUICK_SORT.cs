// QUICK SORT (SẮP XẾP NHANH)
static void Quick_Sort(int[] arr, int left, int right){
            if (left < right){
                int pivot = Partition(arr, left, right);
                if (pivot > 1){
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right){
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
}
static int Partition(int[] arr, int left, int right){
            int pivot = arr[left];
            while (true){
                while (arr[left] < pivot){
                    left++;
                }
                while (arr[right] > pivot){
                    right--;
                }
                if (left < right){
                    if (arr[left] == arr[right]) return right;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else{
                    return right;
                }
}  
// Run: QuickSort(A, 0, A.Length - 1);      
