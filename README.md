# StrangeEqualityComparer

To reproduce the strange behaviour do th following steps.

1. Load the solution "Library" and build the solution as Release/AnyCPU
2. Load the solution "TestApp" and build the solution as Debug/AnyCPU
  * It's important that "Prefer 32 bit" is disabled and the debug option "Suppress JIT optimization on module load (Managed only)" is unchecked.
3. Run the solution and you will see the problem. Values above 32767 cannot checked on equality correctly.

You can now switch on the "Optimize" checkbox in the poject settings of the TestApp and the problem is fixed.
