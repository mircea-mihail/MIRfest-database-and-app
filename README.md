# MIRfest-database-and-app
Acest proiect reprezinta rezultatul primului meu semestru de baze de date.

## Baza de date
Baza de date este stocata in Microsoft SQL Server si implementata cu Microsoft SQL Server Management Studio. Toate informatiile utile se afla in pdf-ul "documentatie_baza_de_date.pdf".

## Interfata
Interfata a fost facuta simplist in Visual Studio, cu un Forms template. Exemple cu felul in care aceasta functioneaza sunt in pdf-ul "documentatie_interfata.pdf".

## Feedback-ul cursantului
- documentatie facuta in graba: detalii scapate printre crapaturi precum numarul de telefon fiind varchar(100) si constrangeri neexplicate
- interogarea cu having are in having ceva ce putea fi pus si intr-un where -> ar fi trebuit sa pun o funcite specifica grupurilor acolo.
- prima vizualizare implementata nu permite LMD. Doar cu datele din tabelul intermediar "contine" ar fi putut, dar id-ul trupei si id-ul artistului au fost luate din entitatile "trupe" si "artisti", nu din "contine"
- a doua vizualizare nu este complexa. O astfel de vizualizare trebuie sa nu permita utilizatorului sa modifice datele din tabele.
