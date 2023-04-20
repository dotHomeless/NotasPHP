#pragma once

#include "targetver.h"
#include <stdio.h>
#include <tchar.h>
#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS      // alguns construtores CString serão explícitos
#define _AFX_NO_MFC_CONTROLS_IN_DIALOGS         // remover o suporte para controles MFC em caixas de diálogo

#ifndef VC_EXTRALEAN
#define VC_EXTRALEAN            // Excluir itens raramente utilizados dos cabeçalhos do Windows
#endif

#include <afx.h>
#include <afxwin.h>         // Componentes principais e padrão do MFC
#include <afxext.h>         // Extensões do MFC
#ifndef _AFX_NO_OLE_SUPPORT
#include <afxdtctl.h>           // Suporte MFC para Controle Comum do Internet Explorer 4
#endif
#ifndef _AFX_NO_AFXCMN_SUPPORT
#include <afxcmn.h>                     // Suporte do MFC para Controles Comuns do Windows
#endif // _AFX_NO_AFXCMN_SUPPORT

#include <iostream>
