import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int arr[] = new int[n];
        for(int arr_i=0; arr_i < n; arr_i++){
            arr[arr_i] = in.nextInt();
        }
        
        //even
        long posCount  = Arrays.stream(arr).filter(i -> i > 0).count();
        long negCount  = Arrays.stream(arr).filter(i -> i < 0).count();
        long zeroCount = Arrays.stream(arr).filter(i -> i == 0).count();
                
        System.out.println(String.format("%.6f", (float)posCount/n));
        System.out.println(String.format("%.6f", (float)negCount/n));
        System.out.println(String.format("%.6f", (float)zeroCount/n));
        
    }
}
