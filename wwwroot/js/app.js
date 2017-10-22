(function () {
    'use strict';

    angular.module('app', [
        // Angular modules 
        'ngRoute'

        // Custom modules 

        // 3rd Party Modules

    ]);
})();


(function () {
    'use strict';
    angular.module('ddApp', ['lvl.directives.dragdrop']) // register the directive with your app module
        .controller('ddController', ['$scope', function ($scope, $timeout) { // function referenced by the drop target
            $scope.dropped = function (dragEl, dropEl) {
                //this is application logic, for the demo we just want to color the grid squares
                //the directive provides a native dom object, wrap with jqlite
                var drop = angular.element(dropEl);
                var drag = angular.element(dragEl);

                //clear the previously applied color, if it exists
                var bgClass = drop.attr('data-color');
                if (bgClass) {
                    drop.removeClass(bgClass);
                }

                //add the dragged color
                bgClass = drag.attr("data-color");
                drop.addClass(bgClass);
                drop.attr('data-color', bgClass);

                //if element has been dragged from the grid, clear dragged color
                if (drag.attr("x-lvl-drop-target")) {
                    drag.removeClass(bgClass);
                }
            };
        }]);
})();



var app2 = angular.module('markerModal', ['schemodal']);

app2.directive('modalDialog2', function () {
    return {
        restrict: 'E',
        scope: {
            show: '='
        },
        replace: true, // Replace with the template below
        transclude: true, // we want to insert custom content inside the directive
        link: function (scope, element, attrs) {
            scope.dialogStyle = {};
            if (attrs.width)
                scope.dialogStyle.width = attrs.width;
            if (attrs.height)
                scope.dialogStyle.height = attrs.height;
            scope.hideModal = function () {
                scope.show = false;
            };
        },
        template: "<div class='ng-modal' ng-show='show'><div class='ng-modal-overlay' ng-click='hideModal()'></div><div class='ng-modal-dialog' ng-style='dialogStyle'><div class='ng-modal-close' ng-click='hideModal()'>X</div><div class='ng-modal-dialog-content' ng-transclude></div></div></div>"
    };
});


app2.controller('ModalCtrl2', ['$scope', function ($scope) {
    $scope.modalShown2 = false;
    $scope.toggleModal2 = function () {
        $scope.modalShown2 = !$scope.modalShown2;
    };
}]);
