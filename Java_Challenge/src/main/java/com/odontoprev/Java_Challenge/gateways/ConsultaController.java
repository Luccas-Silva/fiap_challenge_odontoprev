package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Consulta;
import com.odontoprev.Java_Challenge.domains.Dentista;
import com.odontoprev.Java_Challenge.gateways.requests.ConsultaPatchDateConsulta;
import com.odontoprev.Java_Challenge.gateways.requests.ConsultaPatchTipoConsulta;
import com.odontoprev.Java_Challenge.gateways.requests.ConsultaPatchValorConsulta;
import com.odontoprev.Java_Challenge.gateways.requests.DentistaPatchEmail;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Map;
import java.util.Optional;

@RestController
@RequestMapping("/consulta")
@RequiredArgsConstructor
@Validated
public class ConsultaController {

    private final ConsultaRepository consultaRepository;

    @GetMapping
    public ResponseEntity<Map<String, String>> comandosConsulta() {

        Map<String, String> comandos = Map.of(
                "Listar Consultas", "/consultas",
                "Obter Consulta", "/{consultaId}",
                "Atualiza Date Consulta", "/{consultaId}/date-consulta",
                "Atualiza Tipo Consulta", "/{consultaId}/tipo-consulta",
                "Atualiza Valor Consulta", "/{consultaId}/valor-consulta",
                "Criar Consulta", " "
        );
        return ResponseEntity.ok(comandos);
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
    public Consulta PostConsulta(@RequestBody Consulta consulta) {
        return consultaRepository.save(consulta);
    }

}
