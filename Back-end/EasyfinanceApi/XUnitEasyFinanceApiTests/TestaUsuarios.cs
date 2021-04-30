using System;
using Xunit;
using EasyfinanceApi;
using EasyfinanceApi.Controllers;
using EasyfinanceApi.Data;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using EasyfinanceApi.Model;
using System.Collections.Generic;
using System.Text;

namespace XUnitEasyFinanceApiTests
{
    public class TestaUsuarios
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;
        private int idUsuario = 1;

        public TestaUsuarios()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task CriarUsuario()
        {
            //Arrange
            string url = $"/api/Usuarios";

            Usuarios us = new Usuarios() { id = 0, login = "UsuarioTeste", nome = "UsuarioTeste", senha = "1234", status = "Ativo" };

            var content = new StringContent(JsonConvert.SerializeObject(us), Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync(url, content);
            Usuarios usuarios = JsonConvert.DeserializeObject<Usuarios>(await response.Content.ReadAsStringAsync());

            // Assert
            response.EnsureSuccessStatusCode();

        }

        [Fact]
        public async Task SelecionarUmUsuario()
        {
            //Arrange
            string url = $"/api/Usuarios/1";

            // Act
            var response = await _client.GetAsync(url);
            Usuarios usuarios = JsonConvert.DeserializeObject<Usuarios>(await response.Content.ReadAsStringAsync());
            response.EnsureSuccessStatusCode();

            // Assert
            Assert.True(usuarios != null, $"Usuarios retornado com sucesso!");
        }

        [Fact]
        public async Task SelecionarUsuarios()
        {
            //Arrange
            string url = $"/api/Usuarios";

            // Act
            var response = await _client.GetAsync(url);
            List<Usuarios> usuarios = JsonConvert.DeserializeObject<List<Usuarios>>(await response.Content.ReadAsStringAsync());
            response.EnsureSuccessStatusCode();

            // Assert
            Assert.True(usuarios.Count > 0, "Usuarios retornados");
        }

    /*    [Fact]
        public async Task EditarUsuario()
        {
            //Arrange
            string url = $"/api/Usuarios";

            // Act
            var response = await _client.GetAsync(url);
            List<Usuarios> usuarios = JsonConvert.DeserializeObject<List<Usuarios>>(await response.Content.ReadAsStringAsync());
            response.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(3, usuarios.Count);
        }

        [Fact]
        public async Task ExcluirUsuario()
        {
            //Arrange
            string url = $"/api/Usuarios";

            // Act
            var response = await _client.GetAsync(url);
            List<Usuarios> usuarios = JsonConvert.DeserializeObject<List<Usuarios>>(await response.Content.ReadAsStringAsync());
            response.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(3, usuarios.Count);
        }*/

    }
}
