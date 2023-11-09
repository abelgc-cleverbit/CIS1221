% use swipl to interactively run this file
% use [gcd]. to load the definitions in this file
% run using 
%   - gcd(100,230,X).
%   - gcd_euc(100,230,X).
%   - gcdl([100,200,300], X).
% use halt. to quit

% slow approach using Euclides' original algorithm
gcd_euc(0, X, X):- X > 0, !.
gcd_euc(X, Y, Z):- X >= Y, X1 is X-Y, gcd_euc(X1,Y,Z).
gcd_euc(X, Y, Z):- X < Y, X1 is Y-X, gcd_euc(X1,X,Z).


% accelerated algorithm using mod operator
gcd(X, Y, X):- Y = 0, !.
gcd(X, Y, Z):- X1 is (X mod Y), gcd(Y, X1, Z).


% gcd of a list
gcdl([X1,X2|T], Z) :- gcd(X1,X2,X), gcdl([X|T], Z).
gcdl([X1,X2], Z):- gcd(X1,X2,Z).
