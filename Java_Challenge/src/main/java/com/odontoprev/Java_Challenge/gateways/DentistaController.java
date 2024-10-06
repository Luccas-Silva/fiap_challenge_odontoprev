package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Cliente;
import com.odontoprev.Java_Challenge.domains.Consulta;
import com.odontoprev.Java_Challenge.domains.Dentista;
import com.odontoprev.Java_Challenge.gateways.requests.*;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Map;
import java.util.Optional;

@RestController
@RequestMapping("/dentista")
@RequiredArgsConstructor
@Validated
public class DentistaController {

    private final DentistaRepository dentistaRepository;

    @GetMapping
    public ResponseEntity<Map<String, String>> comandosDentista() {
        Map<String, String> comandos = Map.of(
                "Listar Dentistas", "/dentistas",
                "Obter Dentista", "/{dentistaId}",
                "Deletar Dentista", "/{dentistaId}",
                "Criar Dentista", " "
        );
        return ResponseEntity.ok(comandos);
    }

    @GetMapping("/dentistas")
    public ResponseEntity<List<Dentista>> getListDentista( ){
        List<Dentista> listDentistas = dentistaRepository.findAll();
        return ResponseEntity.ok(listDentistas);
    }

    @GetMapping("/{dentistaId}")
    public ResponseEntity<Optional<Dentista>> getDentista(@PathVariable String dentistaId) {
        Optional<Dentista> optionalDentista = dentistaRepository.findById(dentistaId);
        return ResponseEntity.ok(optionalDentista);
    }

    @PatchMapping("/{dentistaId}/email")
    public ResponseEntity<DentistaPatchEmail> patchEmail(@PathVariable String dentistaId, @RequestBody DentistaPatchEmail email) {
        return ResponseEntity.ok(email);
    }

    @PatchMapping("/{dentistaId}/celular")
    public ResponseEntity<DentistaPatchCelular> patchCelular(@PathVariable String dentistaId, @RequestBody DentistaPatchCelular celular) {
        return ResponseEntity.ok(celular);
    }

    @PatchMapping("/{dentistaId}/cep-clinica")
    public ResponseEntity<DentistaPatchCepClinica> patchCepClinica(@PathVariable String dentistaId, @RequestBody DentistaPatchCepClinica cepClinica) {
        return ResponseEntity.ok(cepClinica);
    }

    @PatchMapping("/{dentistaId}/nome-clinica")
    public ResponseEntity<DentistaPatchNomeClinica> patchNomeClinica(@PathVariable String dentistaId, @RequestBody DentistaPatchNomeClinica nomeClinica) {
        return ResponseEntity.ok(nomeClinica);
    }

    @PatchMapping("/{dentistaId}/tipo-clinica")
    public ResponseEntity<DentistaPatchTipoClinica> patchTipoClinica(@PathVariable String dentistaId, @RequestBody DentistaPatchTipoClinica tipoClinica) {
        return ResponseEntity.ok(tipoClinica);
    }

    @PatchMapping("/{dentistaId}/alvara-funcionamento")
    public ResponseEntity<DentistaPatchAlvaraFuncionamento> patchAlvaraFuncionamento(@PathVariable String dentistaId, @RequestBody DentistaPatchAlvaraFuncionamento alvaraFuncionamento) {
        return ResponseEntity.ok(alvaraFuncionamento);
    }

    @PatchMapping("/{dentistaId}/redesocial-site")
    public ResponseEntity<DentistaPatchRedeSocialSite> patchAlvaraRedeSocialSite(@PathVariable String dentistaId, @RequestBody DentistaPatchRedeSocialSite siteRedesSocial) {
        return ResponseEntity.ok(siteRedesSocial);
    }

    @PostMapping
    public Dentista postDentista(@RequestBody Dentista dentista) {
        return dentistaRepository.save(dentista);
    }

    @DeleteMapping("/{dentistaId}")
    public ResponseEntity<Optional<Dentista>> deleteDentista(@PathVariable String dentistaId) {
        Optional<Dentista> optionalDentista = dentistaRepository.findById(dentistaId);
        if (optionalDentista.isPresent()) {
            dentistaRepository.delete(optionalDentista.get());
            return ResponseEntity.noContent().build();
        } else {
            return ResponseEntity.notFound().build();
        }
    }

}
