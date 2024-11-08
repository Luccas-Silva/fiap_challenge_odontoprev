package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Cliente;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchCEP;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchCelular;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchTipoPlano;
import com.odontoprev.Java_Challenge.gateways.requests.ClientePatchEmail;
import lombok.RequiredArgsConstructor;
import org.springframework.hateoas.EntityModel;
import org.springframework.hateoas.Link;
import org.springframework.hateoas.server.mvc.WebMvcLinkBuilder;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Map;
import java.util.Optional;

import static org.springframework.hateoas.server.mvc.WebMvcLinkBuilder.linkTo;
import static org.springframework.hateoas.server.mvc.WebMvcLinkBuilder.methodOn;

@RestController
@RequestMapping("/cliente")
@RequiredArgsConstructor
@Validated
public class ClienteController {

    private final ClienteRepository clienteRepository;

    @GetMapping
    public ResponseEntity<EntityModel<Map<String, String>>> comandosCliente() {
        Map<String, String> comandos = Map.of(
                "Listar Clientes", "/clientes",
                "Obter Cliente", "/{clienteId}",
                "Deletar Cliente", "/{clienteId}",
                "Criar Cliente", "/"
        );

        EntityModel<Map<String, String>> entityModel = EntityModel.of(comandos);

        // Add self link
        entityModel.add(linkTo(methodOn(ClienteController.class).comandosCliente()).withSelfRel());

        // Add links to other relevant endpoints
        entityModel.add(linkTo(methodOn(ClienteController.class).getListClientes()).withRel("listar-clientes"));
        entityModel.add(linkTo(methodOn(ClienteController.class).getCliente("{clienteId}")).withRel("obter-cliente"));
        entityModel.add(linkTo(methodOn(ClienteController.class).deleteCliente("{clienteId}")).withRel("deletar-cliente"));

        return ResponseEntity.ok(entityModel);
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
    public Cliente postCliente(@RequestBody Cliente cliente) {
        return clienteRepository.save(cliente);
    }

    @DeleteMapping("/{clienteId}")
    public ResponseEntity<Optional<Cliente>> deleteCliente(@PathVariable String clienteId) {
        Optional<Cliente> optionalCliente = clienteRepository.findById(clienteId);
        if (optionalCliente.isPresent()) {
            clienteRepository.delete(optionalCliente.get());
            return ResponseEntity.noContent().build();
        } else {
            return ResponseEntity.notFound().build();
        }
    }

}
