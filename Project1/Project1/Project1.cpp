// Project1.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include "pch.h"
#include "framework.h"
#include "Project1.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// O único objeto de aplicativo

CWinApp theApp;

using namespace std;

int main()
{
    int nRetCode = 0;

    HMODULE hModule = ::GetModuleHandle(nullptr);

    if (hModule != nullptr)
    {
        // inicializar MFC e imprimir e erro em caso de falha
        if (!AfxWinInit(hModule, nullptr, ::GetCommandLine(), 0))
        {
            // TODO: codifique o comportamento do seu aplicativo aqui.
            wprintf(L"Erro Fatal: falha na inicialização de MFC\n");
            nRetCode = 1;
        }
        else
        {
            // TODO: codifique o comportamento do seu aplicativo aqui.
        }
    }
    else
    {
        // TODO: alterar o código de erro para adequar-se às suas necessidades
        wprintf(L"Erro Fatal: GetModuleHandle falhou\n");
        nRetCode = 1;
    }

    return nRetCode;
}
