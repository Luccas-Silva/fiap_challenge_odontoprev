package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Cliente;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchCEP;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchCelular;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchTipoPlano;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchEmail;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.Date;
import java.util.List;
import java.util.Map;
import java.util.Optional;

@RestController
@RequestMapping("/cliente")
@RequiredArgsConstructor
@Validated
public class ClienteController {

    private final ClienteRepository clienteRepository;

    @GetMapping
    public ResponseEntity<Map<String, String>> comandosCliente() {

        Map<String, String> comandos = Map.of(
                "Listar Clientes", "/clientes",
                "Obter Cliente", "/{clienteId}",
                "Atualiza Email", "/{clienteId}/email",
                "Atualiza Celular", "/{clienteId}/celular",
                "Atualiza CEP", "/{clienteId}/cep",
                "Atualiza Tipo-Plano", "/{clienteId}/tipo-plano",
                "Criar Cliente", " "
        );
        return ResponseEntity.ok(comandos);
    }

    @GetMapping("/clientes")
    public ResponseEntity<List<Cliente>> getListClientes( ){
        List<Cliente> listClientes = clienteRepository.findAll();
        return ResponseEntity.ok(listClientes);
    }

    @GetMapping("/{clienteId}")
    public ResponseEntity<Optional<Cliente>> getCliente(@PathVariable String clienteId) {
        Optional<Cliente> optionalCliente = clienteRepository.findById(clienteId);
        return ResponseEntity.ok(optionalCliente);
    }

    @PatchMapping("/{clienteId}/email")
    public ResponseEntity<ClientePatchEmail> patchEmail(@PathVariable String clienteId, @RequestBody ClientePatchEmail email) {
        return ResponseEntity.ok(email);
    }

    @PatchMapping("/{clienteId}/celular")
    public ResponseEntity<ClientePatchCelular> patchCelular(@PathVariable String clienteId, @RequestBody ClientePatchCelular celular) {
        return ResponseEntity.ok(celular);
    }

    @PatchMapping("/{clienteId}/cep")
    public ResponseEntity<ClientePatchCEP> patchCEP(@PathVariable String clienteId, @RequestBody ClientePatchCEP cep) {
        return ResponseEntity.ok(cep);
    }

    @PatchMapping("/{clienteId}/tipo-plano")
    public ResponseEntity<ClientePatchTipoPlano> patchTipoPlano(@PathVariable String clienteId, @RequestBody ClientePatchTipoPlano tipoPlano) {
        return ResponseEntity.ok(tipoPlano);
    }

    @PostMapping
    public Cliente PostCliente(@RequestBody Cliente cliente) {
        return clienteRepository.save(cliente);
    }


}
