package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Cliente;
import com.odontoprev.Java_Challenge.domains.Dentista;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

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

                "Atualiza Email", "/{clienteId}/email",
                "Atualiza Celular", "/{clienteId}/celular",
                "Atualiza CEP", "/{clienteId}/cep",
                "Atualiza Tipo-Plano", "/{clienteId}/tipo-plano",

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

}
