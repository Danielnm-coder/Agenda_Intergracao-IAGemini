using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;
using ProjetoGemini.Dtos;
using System.Text;

namespace ProjetoGemini.Services
{
    public class GeminiService
    {
        private readonly string _apiUrl;
        private readonly string _apiKey;

        public GeminiService(IConfiguration configuration)
        {
            _apiUrl = configuration["Gemini:ApiUrl"];
            _apiKey = configuration["Gemini:ApiKey"];
        }

        public string OrganizarAgenda(AgendaRequestDto request)
        {
            // Construindo a string de tarefas
            var tarefas = "";
            foreach (var tarefa in request.Tarefas)
            {
                tarefas += $"Tarefa: {tarefa.Nome}, horas necessárias: {tarefa.TempoEmHoras}, " +
                          $"complexidade: {tarefa.Complexidade}, urgência: {tarefa.Urgencia}. ";
            }

            // Criando o contexto
            var pergunta = $"Planeje e organize a minha agenda de tarefas para o periodo de datas de: {request.DataInicio} até {request.DataFim} " +
                           $"e sabendo que a minha disponibilidade de trabalho é: {request.Descricao}. " +
                           "Preciso que defina a melhor data de inicio, fim e horário para execução de cada tarefa, seguem: " +
                           tarefas;

            // Organizando os DTOs
            var part = new GeminiPartRequestDto
            {
                Text = pergunta
            };

            var content = new GeminiContentRequestDto
            {
                Parts = new[] { part }
            };

            var generate = new GeminiGenereteContentRequestDto
            {
                Contents = new[] { content }
            };

            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(_apiUrl + _apiKey, generate).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception($"Erro ao enviar a requisição: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }

        public string RealizarBusca(string busca)
        {
            // Organizando os DTOs
            var part = new GeminiPartRequestDto
            {
                Text = busca
            };

            var content = new GeminiContentRequestDto
            {
                Parts = new[] { part }
            };

            var generate = new GeminiGenereteContentRequestDto
            {
                Contents = new[] { content }
            };

            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(_apiUrl + _apiKey, generate).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception($"Erro ao enviar a requisição: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }
    }
}



