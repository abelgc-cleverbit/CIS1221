% use swipl to interactively run this file
% use [hanoi]. to load the definitions in this file
% run using 
% - hanoi(3, left, right, center).

hanoi(1, SOURCE, TARGET,_) :-  
    write('move top disk from '),  
    write(SOURCE),  
    write(' to '),  
    write(TARGET),
    nl.  
  
hanoi(P, SOURCE, TARGET, AUX) :-  
    P>1,  
    P1 is P-1,  
    hanoi(P1, SOURCE, AUX, TARGET),  
    hanoi(1, SOURCE, TARGET,_),  
    hanoi(P1, AUX, TARGET, SOURCE).  