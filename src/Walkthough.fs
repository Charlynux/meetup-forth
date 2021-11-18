\ Code expérimenté pendant le Meetup

\ Un peu de maths
1 2 + .
CR
1 2 +  4 * .
CR
42 17 255 -13 MAX MAX MAX .

1
2
3
CR
\ Affichons le contenu de la stack
.s

\ Dépilons pour ignorer les 3 chiffres saisis
DROP DROP DROP

\ Un premier "mot" qui influence la stack 
CR
42 DUP + .
CR
2 DUP DUP DUP * * * .

\ On copie le deuxième de la pile.
42 17 OVER
CR
.s
DROP DROP DROP

\ Une petite rotation
1 2 3
CR
.s
ROT
.s
DROP DROP DROP

\ Copie de deux éléments
1 2 
OVER OVER .s
DROP DROP

2DUP .s ( 2DUP =  OVER OVER ) 
DROP DROP DROP DROP

\ Double rotation
1 2 3
ROT ROT .s
DROP DROP

-ROT .s ( -ROT =  ROT ROT ) 
DROP DROP DROP

/ Création de mots : le tri
: SORT2 2DUP MAX -ROT MIN ;
: SORT3 SORT2 ROT SORT2 -ROT SORT2 ROT ;

123 45 SORT2

123 45 678 SORT3

CR BYE