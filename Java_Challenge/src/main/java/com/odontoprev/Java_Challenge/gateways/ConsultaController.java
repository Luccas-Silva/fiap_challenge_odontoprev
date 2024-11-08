package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Cliente;
import com.odontoprev.Java_Challenge.domains.Consulta;
import com.odontoprev.Java_Challenge.domains.Dentista;
import com.odontoprev.Java_Challenge.gateways.requests.*;
import lombok.RequiredArgsConstructor;
import org.springframework.hateoas.EntityModel;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Map;
import java.util.Optional;

import static org.springframework.hateoas.server.mvc.WebMvcLinkBuilder.linkTo;
import static org.springframework.hateoas.server.mvc.WebMvcLinkBuilder.methodOn;

@RestController
@RequestMapping("/consulta")
@RequiredArgsConstructor
@Validated
public class ConsultaController {

    private final ConsultaRepository consultaRepository;

    @GetMapping
    public ResponseEntity<EntityModel<Map<String, String>>> comandosConsulta() {

        Map<String, String> comandos = Map.of(
                "Listar Consultas", "/consultas",
                "Obter Consulta", "/{consultaId}",
                "Deletar Consulta", "/{consultaId}",
                "Criar Consulta", "/"
        );

        EntityModel<Map<String, String>> entityModel = EntityModel.of(comandos);

        // Add self link
        entityModel.add(linkTo(methodOn(ConsultaController.class).comandosConsulta()).withSelfRel());

        // Add links to other relevant endpoints
        entityModel.add(linkTo(methodOn(ConsultaController.class).getListConsultas()).withRel("listar-consultas"));
        entityModel.add(linkTo(methodOn(ConsultaController.class).getConsulta("{consultaId}")).withRel("obter-consulta"));
        entityModel.add(linkTo(methodOn(ConsultaController.class).deleteConsulta("{consultaId}")).withRel("deletar-consulta"));

        return ResponseEntity.ok(entityModel);
    }

    @GetMapping("/consultas")
    public ResponseEntity<List<Consulta>> getListConsultas( ){
        List<Consulta> listConsultas = consultaRepository.findAll();
        return ResponseEntity.ok(listConsultas);
    }

    @GetMapping("/{consultaId}")
    public ResponseEntity<Optional<Consulta>> getConsulta(@PathVariable String consultaId) {
        Optional<Consulta> optionalConsulta = consultaRepository.findById(consultaId);
        return ResponseEntity.ok(optionalConsulta);
    }

    @PatchMapping("/{consultaId}/date-consulta")
    public ResponseEntity<ConsultaPatchDateConsulta> patchDateConsulta(@PathVariable String consultaId, @RequestBody ConsultaPatchDateConsulta dateConsulta) {
        return ResponseEntity.ok(dateConsulta);
    }

    @PatchMapping("/{consultaId}/tipo-consulta")
    public ResponseEntity<ConsultaPatchTipoConsulta> patchTipoConsulta(@PathVariable String consultaId, @RequestBody ConsultaPatchTipoConsulta tipoConsulta) {
        return ResponseEntity.ok(tipoConsulta);
    }

    @PatchMapping("/{consultaId}/valor-consulta")
    public ResponseEntity<ConsultaPatchValorConsulta> patchValorConsulta(@PathVariable String consultaId, @RequestBody ConsultaPatchValorConsulta valorConsulta) {
        return ResponseEntity.ok(valorConsulta);
    }

    @PostMapping
    public Consulta postConsulta(@RequestBody Consulta consulta) {
        return consultaRepository.save(consulta);
    }

    @DeleteMapping("/{consultaId}")
    public ResponseEntity<Optional<Consulta>> deleteConsulta(@PathVariable String consultaId) {
        Optional<Consulta> optionalConsulta = consultaRepository.findById(consultaId);
        if (optionalConsulta.isPresent()) {
            consultaRepository.delete(optionalConsulta.get());
            return ResponseEntity.noContent().build();
        } else {
            return ResponseEntity.notFound().build();
        }
    }

}
