# Découvrons Forth

[Lien Meetup](https://www.meetup.com/fr-FR/Software-Crafters-Amiens/events/281609403/)

## Code

J'ai repris quelques commandes que nous avons vu pendant la soirée et les ai placées dans un fichier source : [Walkthough.fs](src/Walkthough.fs).

## Avis personnel

Un avis tout à fait subjectif tiré de moins de deux heures d'expérimentation.

J'avais entamé la soirée en m'interrogeant sur la qualification du langage de haut ou bas niveau. (Le site de Forth parlant lui-même de "high-level".)

S'il est bien plus aisé à manipuler qu'un assembleur, il reste très "primaire" dans ce qu'il offre au développeur. L'étude du langage est intéressante pour découvrir une autre façon de développer et pour le "défi". Par contre, là où Prolog avait laissé entrevoir des usages dans le monde réel, ce n'est pas le cas de Forth.

Je ne fais pas d'embarqué et n'ai pas de raison de faire de l'assembleur. Peut-être que si c'était le cas, je verrais ce langage d'un autre oeil.

Un autre aspect qui pourrait être intéressant serait de se pencher sur l'implémentation d'un interprêteur Forth. A l'occasion de la Nightcode 2020, j'avais mis au défi les étudiants d'implémenter une calculatrice en notation polonaise inversée. Je trouve que le concept de base représente un exercice intéressant, ajouter quelques `DUP`, `ROT` ou `OVER` pourrait être un petit défi et ouvrir quelques perspectives intéressantes.

## Références

- Site officiel - https://www.forth.com/
- Gforth - https://www.gnu.org/software/gforth/
- Forth in 100 steps - https://leanpub.com/forthin100steps
- A Webserver in Forth - https://bernd-paysan.de/httpd-en.html

### Galileo Patch

Ron Garret rédige un patch pour le code Forth de la sonde Galileo.

> Also in 1993 I used MCL to help generate a code patch for the Gallileo magnetometer. The magnetometer had an RCA1802 processor, 2k each of RAM and ROM, and was programmed in Forth using a development system that ran on a long-since-decommissioned Apple II. The instrument had developed a bad memory byte right in the middle of the code. The code needed to be patched to not use this bad byte. The magnetometer team had originally estimated that resurrecting the development environment and generating the code patch would take so long that they were not even going to attempt it. Using Lisp I wrote from scratch a Forth development environment for the instrument (including a simulator for the hardware) and used it to generate the patch. The whole project took just under 3 months of part-time work.

C'est ce paragraphe qui m'a donné envie d'en savoir plus sur Forth.

- Lisping at JPL (l'article complet) - https://flownet.com/gat/jpl-lisp.html
- Le code - https://github.com/rongarret/gll-mag-patch

### Porth

Un développeur qui implémente son propre langage à pile.

- Playlist Youtube - https://youtu.be/8QP2fDBIxjM
- Repository - https://gitlab.com/tsoding/porth

### Divers

- L'éditeur ed(1) évoqué pendant la soirée - https://linux.die.net/man/1/ed

## Génération des slides

Le fichier `slides.pdf` est dégénéré depuis le `slides.md` via [Marp](https://marp.app/).

```shell
npx @marp-team/marp-cli@latest content/slides.md -o slides.pdf
```
