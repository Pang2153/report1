#include <stdio.h>
#pragma warning(disable 4996)
void aAconvert(char* input) {
    for (int i = 0; input[i] != '\0'; i++) {
        if (input[i] >= 'a' && input[i] <= 'z') {
            input[i] = input[i] - 32;
        }
        else if (input[i] >= 'A' && input[i] <= 'Z') {
            input[i] = input[i] + 32;
        }
    }
}

int main() {
    char input[25566];
    printf("��ȯ�� ������ �Է��ϼ���: ");
    fgets(input, sizeof(input), stdin);
    aAconvert(input);
    printf("���ܾ� ��ȯ: %s\n", input);
    return 0;
}