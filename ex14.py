def fib(n):
    if n <= 1:
        return n
    else:
        return(fib(n+1) + fib(n-2))
    int(input("Enter a number of terms: "))
for i in range(n):
    print fib(i)
