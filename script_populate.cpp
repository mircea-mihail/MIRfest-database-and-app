#include <iostream>
using namespace std;

int main(){
//trupe

    //id_trupa id_manager index_scena nume gen_muzical email
    // for(int i = 2; i < 7; i++){
    //     cout << "insert into Trupe\n";
    //     cout << "values("<<i<<", , , '' , '', '')\n\n";
    // }

//ingineri

    // cout << "--id_ingineri, nume, prenume, ani_experienta, senior_sau_nu\n";
    // for(int i = 1; i < 7; i++){
    //     cout << "insert into Ingineri_de_sunet\n";
    //     cout << "values("<<i<<",'' ,'' , , )\n\n";
    // }

//instrumente
    // cout << "--cod_produs, tip, marca, model\n";
    // for(int i = 1; i < 7; i++){
    //     cout << "insert into Instrumente\n";
    //     cout << "values("<<i<<",'' ,'' , )\n\n";
    // }

//artisti

    // cout << "--id_artist, nume, prenume, ani_in_trupa\n";
    // for(int i = 7; i < 11; i++){
    //     cout << "insert into Artisti\n";
    //     cout << "values("<<i<<",'' ,'' , );\n\n";
    // }

//

//Scene
    // cout << "--index_scena, nume, metri_patrati, acoperita_sau_nu\n";
    // for(int i = 1; i < 4; i++){
    //     cout << "insert into Scene\n";
    //     cout << "values("<<i<<",'' , , );\n\n";
    // }

//echipament
    // cout << "--cod_produs, index_scena, id_inginer, rol, marca, pret\n";
    // for(int i = 1; i < 7; i++){
    //     cout << "insert into Echipament\n";
    //     cout << "values("<<i<<", , , '', '' , );\n\n";
    // }

//canta_la

    // cout << "--cod_produs, id_artist\n";
    // for(int i = 1; i < 7; i++){
    //     cout << "insert into Canta_la\n";
    //     cout << "values( , );\n\n";
    // }

//manageri
    // cout << "--id_manager, nume, prenume, email, nr_telefon\n";
    // for(int i = 1; i < 7; i++){
    //     cout << "insert into Manageri\n";
    //     cout << "values("<<i<<", '', '', '', );\n\n";
    // }

//contine

    // cout << "--id_artist, id_trupa\n";
    // for(int i = 1; i < 7; i++){
    //     cout << "insert into Contine\n";
    //     cout << "values( , );\n\n";
    // }

//piese

    cout << "--id_piesa, id_trupa, titlu, compozitor, durata, gen_muzical\n";
    for(int i = 1; i < 10; i++){
        cout << "insert into Piese\n";
        cout << "values("<<i<<", ,'' ,'' , , '')\n\n";
    }
}