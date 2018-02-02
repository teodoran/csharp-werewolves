csharp-werewolves
=================
_Code examples to go along with the talk ".NET - A guide to facing werewolves without silver bullets"._
_A Kahoot survey to go along with the talk can be found [here](https://play.kahoot.it/#/k/99986548-d14e-44ec-9fa1-22ebc99c8636)._

Talk outline
------------

### Hva vil vi snakke om?
Det er noen ting som er vanskelig å si er bedre enn andre...

Det er noen valg som er riktig og galt.

### Disclaimers
Mye av dette er situasjonsbetinget, vi har laget spissede eksempler.
Er ute etter at folk velger det de heller mot, selv om de ikke alltid ville brukt det ene eller det andre.

### Forklaring
1. Vi presenterer dilemma (hva er tema)
2. Veier eksempel A og B opp mot hverandre. Hva tenker vi?
3. Alle stemmer (30s), vi ser resultater.
4. Spør noen konkrete i salen om hva de valgte og hvorfor.

### Dilemmaer
1. DataState
2. Static
3. Var
4. MethodExtraction
5. Linq
6. (Hvis tid til overs: ExceptionHandling)

### Outro
Burde man gjøre de samme tingene hver gang? Alle i prosjektet?

Er dette nytting å ha et forhold til?
* Være bevisst på hva man velger og hvorfor.


Diff av dilemmaer
-----------------
Branchen `master` inneholder begge versjonene av alle dilemaaene. I tillegg finnes branchen `remus` og `delphine` som hver inneholder en versjon og kan diffes mot hverandre. Diffing kan gjøres på flere måter, men under er noen forslag.

### Diff med VS Code
Installer utvidelsen _Git History Diff_. Denne utvidelsen gjør en rimelig god jobb med å visualisere ulike brancher. Søk etter _GitHD_ i command palette.

### Diff med Meld
[Meld](http://meldmerge.org/) er et mer avansert diff-verktøy, og installeres som et eget verktøy.

1. Installer Meld på ditt system. Bruk f.eks. `sudo apt-get install meld`.
2. Konfigurer git til å bruke Meld som diff-verktøy: `git config --global diff.tool meld`
3. Sjekk ut branchen delphine: `git checkout delphine`
3. Bruk `git difftool` for å diffe delphine mot remus -branchen: `git difftool -d remus`


Installasjon av prosjektet
--------------------------
Prosjektet er satt opp med dotnet core. En mulig måte å få bygget og kjørt det på er beskrevet under.

1. Få fatt i en passende versjon av dotnet core
2. Naviger deg ned i mappen csharp-werewolves/Werewolves
3. Kjør `dotnet restore` for å laste ned avhengigheter
4. Kjør `dotnet build` for å bygge prosjektet
5. Kjør `dotnet run` for å kjøre terminalapplikasjonen som lages


Sample output
-------------

```
/csharp-werewolves/Werewolves> dotnet run
Beware of Werewolves... Press enter to continue.
Press enter to continue.


      /^\      /^\
      |  \    /  |
      ||\ \../ /||
      )'        `(
     ,;`w,    ,w';,
     ;,  ) __ (  ,;
      ;  \(\/)/  ;;
     ;|  |vwwv|    ``-...
      ;  `lwwl'   ;      ```''-.
     ;| ; `"' ; ;              `.
      ;         ,   ,          , |
      '  ;      ;   l    .     | |
      ;    ,  ,    |,-,._|      \;
       ;  ; `' ;   '    \ `\     \;
       |  |    |  |     |   |    |;
       |  ;    ;  |      \   \   (;
       | |      | l       | | \  |
       | |      | |       | |  ) |
       | |      | ;       | |  | |
       ; ,      : ,      ,_.'  | |
      :__'      | |           ,_.'
               `--'
Press enter for DataState:

DataState1: Teodor Elstad
DataState2: Magnus Karlsson

Press enter for Static:

DateStamp1 GetShortDateStamp(): 02-02-2018
DateStamp1 GetLongDateStamp(): MY_SILVER_BULLET_STAMP: 02-02-2018 03:15
DateStamp2 GetShortDateStamp(): 02-02-2018
DateStamp2 GetLongDateStamp(): MY_SILVER_BULLET_STAMP: 02-02-2018 03:15

Press enter for Var:

Var1:
triller, teens, werewolves, vampires
insect, teleportation
monster, frankenstein, lightning

Var2:
triller, teens, werewolves, vampires
insect, teleportation
monster, frankenstein, lightning

Press enter for MethodExtraction:

MethodExtraction1: 122
MethodExtraction2: 122

Press enter for Linq:

Linq1: something CX! somethingsomething CX! again
Linq2: something CX! somethingsomething CX! again

/csharp-werewolves/Werewolves>
```
