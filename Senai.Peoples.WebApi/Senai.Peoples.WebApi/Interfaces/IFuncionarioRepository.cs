﻿using Senai.Peoples.WebApi.Domains;
using System.Collections.Generic;


namespace Senai.Peoples.WebApi.Interfaces
{
    interface IFuncionarioRepository
    {
        List<FuncionarioDomain> ListarFuncionario();

        FuncionarioDomain BuscarFunId(int id);

        void CadastrarFun(FuncionarioDomain funcionarioDomain);

        void AlterarInfoFunId(int id);

        void AlterarInfoFunCorpo(int id,FuncionarioDomain funcionarioDomain);
        
        void DeletarFun(int id);

    }
}
