// LINEAR SEARCH - EXHAUSTIVE (VÉT CẠN)
static int LinearExhaustive (int[] A, int x){
            int n = A.Length;
            for (int i = 0; i < n; i++){
                if (A[i] == x) 
                      return i;
            }
            return -1;
}
