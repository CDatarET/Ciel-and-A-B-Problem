# Ciel-and-A-B-Problem
CodeChef Difficulty 1136 Problem. 

# Ciel and A-B Problem

In Ciel's restaurant, a waiter is in training. Since the waiter isn't very good at arithmetic, he sometimes gives guests the wrong change. To help him improve, Ciel gives him a simple math problem:

> What is A - B (A minus B)?

Surprisingly, the waiter gives the **wrong** answer — but not entirely. His answer has **exactly one incorrect digit**. Can you replicate the same kind of mistake?

## Problem Statement

Given two integers `A` and `B`, output an incorrect result of `A - B` such that:

- The result must be a **positive integer**
- The result must have the **same number of digits** as the correct answer
- **Exactly one digit** must be incorrect (all other digits must match)
- The incorrect result **must not contain leading zeros**

If multiple answers are possible, any valid answer is acceptable.

## Input

Two space-separated integers:


Where:
- `1 ≤ B < A ≤ 1000`

## Output

Print a single integer: an incorrect result of `A - B`, following the conditions above.
