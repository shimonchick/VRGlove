//
// Created by misho on 20/04/19.
//

#ifndef NODEMCU_MULTIPLEXER_H
#define NODEMCU_MULTIPLEXER_H


#define S0 12
#define S1 14
#define S2 2
#define S3 0
#define SIG 17


class Multiplexer {
public:
    explicit Multiplexer(int input_count_param) : input_count(input_count_param){}
    void setup();
    int readInput(unsigned int number);
    void readAllInputs(int results[]);
private:
    int input_count;
    int select_pins[4] = {S0, S1, S2, S3};
    int signal_pin;
};


#endif //NODEMCU_MULTIPLEXER_H
