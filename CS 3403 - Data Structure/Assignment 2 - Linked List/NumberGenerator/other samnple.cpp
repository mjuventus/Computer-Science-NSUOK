        {

        cout << endl << endl << endl << "Unsorted array: " << endl;

        for (int i = 0; i < sizeOfArray; i++)
        {

            printf("%d \n", numberArray[i]);

        }

        while (1) {
            SwapNumber = 0;
            for (int i = 0; i < sizeOfArray - 1; i++)
            {
                if (numberArray[i] > numberArray[i + 1])
                {
                    int temporaryNumber = numberArray[i];
                    numberArray[i] = numberArray[i + 1];
                    numberArray[i + 1] = temporaryNumber;
                    SwapNumber = 1;
                }
            }


            if (SwapNumber == 0) {
                break;
            }




        }
        printf("\n \n Sorted List\n");

        for (int i = 0; i < sizeOfArray; i++)
        {

            printf("%d \n", numberArray[i]);

        }
    }
