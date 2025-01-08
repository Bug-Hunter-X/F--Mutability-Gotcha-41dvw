let mutable x = 1
let mutable y = 2
let z = ref (x + y) // Use a reference cell
printf "%d" !z
x <- 3
z := x + y //Update the reference cell
printf "%d %d" x !z