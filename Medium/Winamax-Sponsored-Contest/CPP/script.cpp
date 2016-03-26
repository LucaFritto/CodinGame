#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;
/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class stack
{
private:
    struct card
    {
        int rank;
        int suit;
        card *next;
        card() {rank=2;suit=0;};
    };
    card *top;
    
public:
    void push(int rank,int suit);
    void push(string elem); //{top=new pila(elem,top);};
    void pushBottom(int rank, int suit);
    void pop(int*,int*);
    int empty() {return top==0;};
    int count();
    void rovescia(stack* nuovo);
    void visualizza();
    void insert(stack* nuovo); 
};

void stack::push(string elem)
{
    card *nuovo;
    nuovo=new card;
    const char* elemValue = elem.c_str();
    //cout << elemValue[0];
    switch (elemValue[1]) {
        case 'D':
            nuovo->suit =0;
            break;
        case 'H':
            nuovo->suit =1;
            break;
        case 'C':
            nuovo->suit = 2;
            break;
        case 'S':
            nuovo->suit = 3;
            break;
        default:
            switch (elemValue[2]) {
                case 'D':
                    nuovo->suit =0;
                    break;
                case 'H':
                    nuovo->suit =1;
                    break;
                case 'C':
                    nuovo->suit = 2;
                    break;
                case 'S':
                    nuovo->suit = 3;
                    break;
            }
            break;
    }
    switch (elemValue[0]) {
        case '1':
            nuovo-> rank = 10;
            break;
        case 'J':
            nuovo->rank = 11;
            break;
        case 'Q':
            nuovo->rank = 12;
            break;
        case 'K':
            nuovo->rank = 13;
            break;
        case 'A':
            nuovo->rank = 15;
            break;
        default:
            nuovo->rank = elemValue[0]-'0';
            break;
    }
    nuovo->next=top;
    top=nuovo;
    //cout << nuovo->rank << endl;
}

void stack::push(int rank, int suit) 
{
    card *nuovo;
    nuovo=new card;
    nuovo->rank = rank;
    nuovo->suit = suit;
    nuovo->next=top;
    top=nuovo;
}

void stack::pushBottom(int rank, int suit) 
{
    card *previous;
    previous = new card;
    card *visual;
    visual = top;
    if (visual == 0) {
        push(rank,suit);
    } else 
    {
        card *nuovo;
        nuovo=new card;
        nuovo->rank = rank;
        nuovo->suit = suit;
        while(visual != 0) {
            previous = visual;
            visual = visual->next;
        }
        previous->next=nuovo;
        nuovo->next = 0;
    }
}

void stack::visualizza()
{
    card *visual;
    visual=top;
    cout << "\n\n Gli elementi del deck sono: \n";
    while(visual != 0)
    {
        cout << " " << visual->rank;
        cout << " " << visual->suit;
        visual=visual->next;
    }
    cout << endl << endl;
}

int stack::count()
{
    int counter = 0;
    card *visual;
    visual=top;
    while(visual != 0)
    {
        counter++;
        visual=visual->next;
    }
    return counter;
}

void stack::pop(int *rank, int *suit)
{
    card *del;
    del=top;
    *rank=del->rank;
    *suit=del->suit;
    top=top->next;                 // rovescia si ferma qui
    delete del;
    //cout << rank << " rank " << suit << " suit" << endl;
}

void stack::rovescia(stack *nuovo)
{
    int rank, suit;
    stack *ptr;
    ptr=new stack();
     while(!nuovo->empty())
     {
        nuovo->pop(&rank, &suit);
        ptr->push(rank,suit);
     }
     nuovo->top=ptr->top;    
}

void war (int rank1,int rank2,int suit1,int suit2, stack* deck1, stack* deck2,stack* deck_1,stack* deck_2)
{
    deck_1->push(rank1, suit1);
    deck_2->push(rank2, suit2);
    int tempRank, tempSuit;
    for (int i = 0; i < 3; i++) {
        if (deck1->empty() || deck2->empty()) {
            cout << "PAT" << endl;
            return;
        }
        deck1->pop(&tempRank, &tempSuit);
        deck_1->push(tempRank, tempSuit);
        deck2->pop(&tempRank, &tempSuit);
        deck_2->push(tempRank, tempSuit);
    }
    if (deck1->empty() || deck2->empty()) {
        cout << "PAT" << endl;
        return;
    }
    int rankp1,suitp1,rankp2,suitp2;
    deck1->pop(&rankp1,&suitp1);
    deck2->pop(&rankp2,&suitp2);
    if (rankp1 > rankp2) {
        deck_1->push(rankp1,suitp1);
        deck_2->push(rankp2,suitp2);
        deck_1->rovescia(deck_1);
        deck_2->rovescia(deck_2);
        while(!deck_1->empty()) {
            deck_1->pop(&rankp1,&suitp1);
            deck1->pushBottom(rankp1,suitp1);
        }
        while(!deck_2->empty()) {
            deck_2->pop(&rankp2,&suitp2);
            deck1->pushBottom(rankp2,suitp2);
        }
    }
    else if (rankp2 > rankp1) {
        deck_1->push(rankp1,suitp1);
        deck_2->push(rankp2,suitp2);
        deck_1->rovescia(deck_1);
        deck_2->rovescia(deck_2);
        while(!deck_1->empty()) {
            deck_1->pop(&rankp1,&suitp1);
            deck2->pushBottom(rankp1,suitp1);
        }
        while(!deck_2->empty()) {
            deck_2->pop(&rankp2,&suitp2);
            deck2->pushBottom(rankp2,suitp2);
        }
    } else {
        war(rankp1,rankp2,suitp1,suitp2, deck1, deck2,deck_1,deck_2);
    }
}

int main() 
{
    int n; 
    cin >> n; cin.ignore();
    stack *deck1 = new stack();
    for (int i = 0; i < n; i++) {
        string cardp1;
        cin >> cardp1; cin.ignore();
        deck1->push(cardp1);
    }
    deck1->rovescia(deck1);
    int m; 
    cin >> m; cin.ignore();
    stack *deck2 = new stack();
    for (int i = 0; i < m; i++) {
        string cardp2;
        cin >> cardp2; cin.ignore();
        deck2->push(cardp2);
    }
    deck2->rovescia(deck2);
    // Write an action using cout. DON'T FORGET THE "<< endl"
    // To debug: cerr << "Debug messages..." << endl;
    int counter = 0;
    while(!(deck1->empty() || deck2->empty())){
        int rankp1,suitp1,rankp2,suitp2;
        deck1->pop(&rankp1,&suitp1);
        deck2->pop(&rankp2,&suitp2);
        if (rankp1 > rankp2) {
            deck1->pushBottom(rankp1,suitp1);
            deck1->pushBottom(rankp2,suitp2);
        }
        else if (rankp2 > rankp1) {
            deck2->pushBottom(rankp1,suitp1);
            deck2->pushBottom(rankp2,suitp2);
        } else {
            stack *deck_1 = new stack();
            stack *deck_2 = new stack();
            war(rankp1,rankp2,suitp1,suitp2, deck1, deck2, deck_1, deck_2);
        }
        counter++;
    }
    if (deck1->empty()) { if (deck2->count() == n+m)    cout << 2 << " " << counter;} 
    else    if (deck1->count() == n+m)  cout << 1 << " " << counter;
}
