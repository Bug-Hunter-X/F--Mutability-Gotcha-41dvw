# F# Mutability Gotcha

This example demonstrates a common pitfall in F# related to mutability and how it affects values in expressions.

The code initializes `x` and `y`, calculates `z`, and then changes `x`.  However, `z` remains unchanged, illustrating that the value of `z` was evaluated at the time of assignment.

The solution shows how to achieve the desired behavior. The key is to understand when changes to mutable variables are reflected and re-evaluate expressions where needed.