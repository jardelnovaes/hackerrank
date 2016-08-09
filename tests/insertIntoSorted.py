import sys

#Defining the insertIntoSorted method
def insertIntoSorted(arr, s):
    ins = arr[s-1]
    printAgain = False
    for i, e in reversed(list(enumerate(arr))):          
        if (i < s-1):
            #Checking the correct position and shift the numbers
            if(e > ins):
                arr[i+1] = e
            elif (e < ins):
                arr[i+1] = ins
                printAgain = True
                break           
            #Printing the array
            sys.stdout.write((" ".join(str(v) for v in arr)) + "\n")             
    
    #Checking the first element
    if (arr[0] > ins) :
        arr[0] = ins
        printAgain = True
                
    if(printAgain):
        #Printing the array
        sys.stdout.write((" ".join(str(v) for v in arr)) + "\n")
            
#Reading inputs
s = int(sys.stdin.readline()) 
ar = list(map(int, sys.stdin.readline().split(" ")))

insertIntoSorted(ar, s)
