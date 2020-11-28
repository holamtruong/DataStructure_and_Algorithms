// BINARY SEARCH (NHỊ PHÂN)
static int BinarySearch (int[] A, int x){
            int left = 0;
            int right = A.Length - 1;
            while(left <= right){
                int mid = (left + right) / 2;
                if (A[mid] == x  ){
                    return mid;
                }else{
                    if (A[mid] > x)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
            }
            return -1;
}
