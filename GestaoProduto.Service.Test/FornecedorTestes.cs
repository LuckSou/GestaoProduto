using GestaoProduto.Domain.DTO.Fornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProduto.Service.Test
{
    public class FornecedorTestes
    {
        public static string NomeFornecedor { get; set; }
        public static string NomeAlterado { get; set; }
        public static string CNPJFornecedor { get; set; }
        public static string CNPJAlterado { get; set; }
        public static int ID { get; set; }

        public List<FornecedorDTO> listaFornecedorDTO = new List<FornecedorDTO>();
        public FornecedorDTO fornecedorDTO = new FornecedorDTO();
        public FornecedorDTOCreate fornecedorDTOCreate = new FornecedorDTOCreate();
        public FornecedorDTOCreateResult fornecedorDTOCreateResult = new FornecedorDTOCreateResult();
        public FornecedorDTOUpdate fornecedorDTOUpdate = new FornecedorDTOUpdate();
        public FornecedorDTOUpdateResult fornecedorDTOUpdateResult = new FornecedorDTOUpdateResult();

        public FornecedorTestes()
        {
            ID = 1;
            NomeFornecedor = Faker.Name.FullName();
            CNPJFornecedor = "12345678910114";
            NomeAlterado = Faker.Name.FullName();
            CNPJAlterado = "123456789101145";

            for (int i = 0; i < 10; i++)
            {
                var dto = new FornecedorDTO()
                {
                    CNPJ = "1234567891011" + i.ToString(),
                    Nome = Faker.Name.FullName()   
                };
                listaFornecedorDTO.Add(dto);
            }

            fornecedorDTO = new FornecedorDTO()
            {
                CNPJ = CNPJFornecedor,
                Nome = NomeFornecedor
            };

            fornecedorDTOCreate = new FornecedorDTOCreate()
            {
                CNPJ = CNPJFornecedor,
                Nome = NomeFornecedor
            };

            fornecedorDTOCreateResult = new FornecedorDTOCreateResult()
            {
                Id= ID,
                CNPJ = CNPJFornecedor,
                Nome = NomeFornecedor,
                CreatAt= DateTime.UtcNow
            };

            fornecedorDTOUpdate = new FornecedorDTOUpdate()
            {
                Id = ID,
                CNPJ = CNPJFornecedor,
                Nome = NomeFornecedor
            };

            fornecedorDTOUpdateResult = new FornecedorDTOUpdateResult()
            {
                Id = ID,
                CNPJ = CNPJFornecedor,
                Nome = NomeFornecedor,
                UpdateAt = DateTime.UtcNow
            };
        }


    }
}
